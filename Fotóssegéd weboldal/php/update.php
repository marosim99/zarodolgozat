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
require_once("../config/connect.php");

    if (isset($_POST["update"])){

      $id = $_SESSION['id'];
      $email = trim($_POST["email"]);
      $user = trim($_POST["username"]);
      $pwd = trim($_POST["password"]);
      $pwd2 = trim($_POST["password2"]);
      $bemutatkozas = trim($_POST["bemutatkozas"]);
      $pw_hash = password_hash($pwd, PASSWORD_DEFAULT);


      if (($pwd == $pwd2) && ($user != $pwd) && (strlen($pwd) > 5)){
          $sql = "UPDATE user SET username='$user', password='$pw_hash', email='$email', bemutatkozas='$bemutatkozas' WHERE id='$id';";
          $conn -> query($sql);


          if ($conn -> error == 0){
              $_SESSION['reg'] = "Sikeres módosítás!";
              echo "<div id='honapkepei'><p>Sikeres adatmódosítás!</p></div>";
              echo "<div id='noreg'><a href='index.php' class='nav-link'>Vissza a főoldalra</a></div>";
          }
          else {
              $_SESSION['reg'] = "Sikertelen adatmódosítás!";
              echo "<div id='honapkepei'><p>Sikertelen adatmódosítás!</p></div>";
              echo "<div id='noreg'><a href='profil_modositasa.php' class='nav-link'>Próbálja újra!</a></div>";
          }
      }
      else {
        $_SESSION['reg'] = "Sikertelen adatmódosítás!";
        echo "<div id='honapkepei'><p>Sikertelen adatmódosítás!</p></div>";
        echo "<div id='noreg'><a href='profil_modositasa.php' class='nav-link'>Próbálja újra!</a></div>";
      }

  }
  else {
    die();
  }
  echo "</body>";
