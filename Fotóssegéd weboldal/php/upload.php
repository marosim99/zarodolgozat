<!DOCTYPE html>
<html lang="hu">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/bootstrap.min.js"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>

    <link rel="stylesheet" href="../style/bootstrap.min.css">
   <link rel="stylesheet" href="../style/styles.css">

    <title>Fotós segéd</title>
  </head>
  <body>
    <?php
    session_start();
    require "menu.php";
    require_once("../config/connect.php");

    if (isset($_POST["upload"])){

      if(!isset($_FILES['fenykep'])){
            die("Hiba a feltöltés során");
        }

      $cim = trim($_POST["cim"]);
      $leiras = trim($_POST["leiras"]);
      $hely = trim($_POST["hely"]);
      $keszDatum = $_POST["datum"];

      $imgName = $_FILES['fenykep']['name'];
      $imgType = $_FILES['fenykep']['type'];
      $imgTmpName = $_FILES['fenykep']['tmp_name'];
      $imgSize = $_FILES['fenykep']['size'];
      $imgFormat = array("image/jpeg", "image/png");
      $ext = pathinfo($imgName, PATHINFO_EXTENSION);
      $UploadFolder = "..\kepek\galeria\\";

      $gepId = $_GET["sorozat"];
      $userId = $_SESSION["id"];

      if (in_array($imgType, $imgFormat) && $imgSize < 16000000){
          move_uploaded_file($imgTmpName, $UploadFolder.$imgName);

          $sql_kep = "INSERT INTO kepek (fajlnev, cim, leiras, hely, feltolt_datum, keszites_datum)
          VALUES ('$imgName','$cim','$leiras','$hely',CURDATE(),'$keszDatum');";
          $conn -> query($sql_kep);

          $sql_foto = "INSERT INTO fotokeszites(gepid, userid) VALUES ($gepId,$userId)";
          $conn -> query($sql_foto);

          header("Location: sajat_kepek.php");
      }
      else {
            echo "<div id='honapkepei'><p>Nem engedélyezett fájltípus, vagy túl nagy méretű!</p></div>";
            echo "<div id='noreg'><a href='kep_feltolt.php' class='nav-link'>Próbálja újra!</a></div>";
          }
    }
    else {
        die();
      }
?>
</body>
</html>
