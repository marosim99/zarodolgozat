<?php
require "header.php";
require_once("../config/connect.php");
    if (isset($_POST["update"])){

      $id = $_SESSION['id'];
      $email = trim($_POST["email"]);
      $user = trim($_POST["username"]);
      $pwd = trim($_POST["password"]);
      $pwd2 = trim($_POST["password2"]);
      $bemutatkozas = trim($_POST["bemutatkozas"]);



      if (($pwd == $pwd2) && ($user != $pwd) && (strlen($pwd) > 5)){
          $sql = "UPDATE user SET username='$user', password='$pwd', email='$email', bemutatkozas='$bemutatkozas' WHERE id='$id';";
          $conn -> query($sql);

          //echo "$sql";

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
