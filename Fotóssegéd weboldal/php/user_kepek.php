<!doctype html>
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
      require_once("../config/connect.php");
      session_start();
      require "menu.php";

       $id = $_GET["id"];
       $sql_user = "SELECT username FROM user WHERE id=$id";
       $res_user = $conn -> query($sql_user);
       $row = $res_user -> fetch_assoc();
       $username = $row["username"];

       $sql = "SELECT kepek.id, kepek.fajlnev, kepek.cim, fotokeszites.gepid, fotokeszites.userid FROM kepek INNER JOIN fotokeszites ON kepek.id = fotokeszites.kepid WHERE fotokeszites.userid=$id ORDER BY feltolt_datum DESC;";
       $res = $conn -> query($sql);

       ?>
   <br>
   <div id="honapkepei">
 	<p><?php echo $username ?> felhasználó képei</p>
 	</div>

   <div class="container">

 <div class="container gallery-container">
   <div class="tz-gallery">
     <?php
     echo '<div class="row mb-3">';
     while($row = $res -> fetch_assoc()){
         echo '<div class="col-md-4">
                       <div class="card photo">
                           <a class="lightbox" href="kep_adatok.php?kepid='.$row["id"].'&gepid='.$row["gepid"].'&userid='.$row["userid"].'">
                           <img src="../kepek/galeria/'.$row["fajlnev"].'" alt="'.$row["cim"].'" class="card-img-top">
                           </a>
                       </div>
                       </div>';
     }
     echo '</div>';
     ?>

     </div>

   </div>

 </div>

 </div>

 </body>
 </html>
