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
       require "menu.php";
       session_start();
       require_once("../config/connect.php");

    if (isset($_POST["kuldes"])){

      $id = $_SESSION["id"];
      $uzenet = trim($_POST["uzenet"]);

      if(empty($uzenet)){
        header('Location: chatroom.php');
        die();
      }
      else{

    $sql = "INSERT INTO chat(uzenet, datum, user_id) VALUES ('$uzenet',CURRENT_TIMESTAMP,$id)";
    $conn -> query($sql);
    header('Location: chatroom.php');



    }
  }
    else {
      die();
    }
echo "</body>";
