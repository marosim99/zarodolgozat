<!DOCTYPE html>
<html lang="hu">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
   <link rel="stylesheet" href="../style/styles.css">

    <title>Fotós segéd</title>
  </head>
  <body>
<?php
session_start();
require "menu.php";
require_once'../config/connect.php';

if (isset($_POST['upload'])){

  if(!isset($_FILES['profkep'])){
        die("Hiba a feltöltés során");
    }

$id = $_SESSION["id"];
$imgName = $_FILES['profkep']['name'];
$imgType = $_FILES['profkep']['type'];
$imgTmpName = $_FILES['profkep']['tmp_name'];
$imgSize = $_FILES['profkep']['size'];
$uploadError = $_FILES['profkep']['error'];
$imgFormat = array("image/jpeg", "image/png");
$ext = pathinfo($imgName, PATHINFO_EXTENSION);
//otthon
//$profkepFolder = "G:\htdocs\zarodolgozat\Fotóssegéd weboldal\kepek\profkep\\";

//suli
$profkepFolder = "J:/htdocs/fotosseged/Fotóssegéd weboldal/kepek/profkep//";
//echo $imgType," ",$imgTmpName," ",$ext;

if (in_array($imgType, $imgFormat) && $imgSize < 16000000){

    if (file_exists($profkepFolder.$id.".jpg")) {
        unlink($profkepFolder.$id.".jpg");
        move_uploaded_file($imgTmpName, $profkepFolder.$imgName);
        rename($profkepFolder.$imgName, $profkepFolder.$id.".".$ext);
        header("Location: profil_modositasa.php");
    } else {
      unlink($profkepFolder.$id.".png");
      move_uploaded_file($imgTmpName, $profkepFolder.$imgName);
      rename($profkepFolder.$imgName, $profkepFolder.$id.".".$ext);
      header("Location: profil_modositasa.php");
    }


} else {
      echo "<div id='honapkepei'><p>Nem engedélyezett fájltípus, vagy túl nagy méretű!</p></div>";
      echo "<div id='noreg'><a href='profil_modositasa.php' class='nav-link'>Próbálja újra!</a></div>";
    }
}
echo "</body>";
