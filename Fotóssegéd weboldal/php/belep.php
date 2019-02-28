<?php
require_once('../config/connect.php');
//require_once('../config/functions.php');

if(isset($_POST['belep'])){
    $username = trim($_POST["username"]);
    $pwd = trim($_POST["password"]);

    require "header.php";

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
                  session_start(); //?
                  $row = $res -> fetch_row();
                  $_SESSION['id'] = $row[0];
                  header('Location: index.php');
                  exit();
              } else {
                  //érvénytelen belépés
                  $_SESSION['error'] = 'Helytelen felhasználónév vagy jelszó!';
                  echo "<div id='honapkepei'><p>Helytelen felhasználónév vagy jelszó!</p></div>";
                  echo "<div id='noreg'><a href='login.php' class='nav-link'>Próbálja újra!</a></div>";
              }
          }
          else {
              header('Location: ../html/index.html');
              exit();
          }
      }

    }
