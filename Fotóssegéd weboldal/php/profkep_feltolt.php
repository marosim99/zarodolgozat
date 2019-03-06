<?php
session_start();
require_once'../config/connect.php';

if (isset($_POST['upload'])){


$imgName = $_FILES['fajl']['name'];
$imgType = $_FILES['fajl']['type'];
$imgTmpName = $_FILES['fajl']['tmp_name'];
$imgSize = $_FILES['fajl']['size'];
$uploadError = $_FILES['fajl']['error'];
$imgFormat = array("image/jpeg", "image/png");

if (in_array($imgType, $imgFormat) && $imgSize < 16000000){
    if (!file_exists("J:\htdocs\fotosseged\Fotóssegéd weboldal\kepek\\".$imgName)) {
        move_uploaded_file($imgTmpName, "../kepek/profkep/".$imgName);
    } else {
        echo "Már létezik ilyen nevű fájl!";
    }
} else {
      echo "Nem engedélyezett fájltípus, vagy túl nagy néretű!";
}
  header("Location: ../index.php");
}
