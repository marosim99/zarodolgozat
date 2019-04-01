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
$profkepFolder = "..\kepek\profkep\\";


if (in_array($imgType, $imgFormat) && $imgSize < 16000000){

    if (file_exists($profkepFolder.$id.".jpg")) { //vizsgálja, hogy van-e már adott id névvel .jpg fájl
        unlink($profkepFolder.$id.".jpg"); //kitörli ha van
        move_uploaded_file($imgTmpName, $profkepFolder.$imgName); //áthelyezi az újat
        rename($profkepFolder.$imgName, $profkepFolder.$id.".".$ext); //átnevezi a user id alapján
        header("Location: profil_modositasa.php");
    } else { //vizsgálja, hogy van-e már adott id névvel .png fájl
      unlink($profkepFolder.$id.".png");  //kitörli ha van
      move_uploaded_file($imgTmpName, $profkepFolder.$imgName); //áthelyezi az újat
      rename($profkepFolder.$imgName, $profkepFolder.$id.".".$ext); //átnevezi a user id alapján
      header("Location: profil_modositasa.php");
    }


} else {
      echo "<div id='honapkepei'><p>Nem engedélyezett fájltípus, vagy túl nagy méretű!</p></div>";
      echo "<div id='noreg'><a href='profil_modositasa.php' class='nav-link'>Próbálja újra!</a></div>";
    }
}
echo "</body>";
