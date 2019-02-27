<?php
session_start();
require_once('../config/connect.php');
//require_once('../config/functions.php');

if(isset($_POST['belep'])){
    $username = trim($_POST["username"]);
    $pwd = trim($_POST["password"]);

    if(empty($username) || empty($pwd)){
      header('Location: ../html/index.html?error=emptyfields');
      exit();
    }
    else{
      $sql = "SELECT * FROM user WHERE username = '$username' AND password = '$pwd';";
      $res = $conn -> query($sql);

          if ($res) {
              if ($res -> num_rows == 1){
                  //belépett
                  session_start();
                  $row = $res -> fetch_row();
                  $_SESSION['uid'] = $row[0];
                  header('Location: ../php/header.php');
                  exit();
              } else {
                  //érvénytelen belépés
                  $_SESSION['error'] = 'Helytelen felhasználónév vagy jelszó!';
                  echo "Sikertelen belépés";
                  echo "<a href='../php/index.php'>Vissza a főoldalra</a>";
              }
          }
          else {
              header('Location: ../html/index.html');
              exit();
          }
      }

    }
