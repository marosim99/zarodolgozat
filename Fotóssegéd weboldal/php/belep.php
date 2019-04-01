<!DOCTYPE html>
<html lang="hu">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>
    <script src="../JS/bootstrap.min.js"></script>

    <link rel="stylesheet" href="../style/bootstrap.min.css">
   <link rel="stylesheet" href="../style/styles.css">


    <title>Fotós segéd</title>
  </head>
  <body>
    <?php
       require "menu.php";
       require_once('../config/connect.php');
       if(isset($_POST['belep'])){
    $username = trim($_POST["username"]);
    $pwd = trim($_POST["password"]);


    if(empty($username) || empty($pwd)){
      echo "<div id='honapkepei'><p>Helytelen felhasználónév vagy jelszó!</p></div>";
      echo "<div id='noreg'><a href='login.php' class='nav-link'>Próbálja újra!</a></div>";
    }
    else{
      $sql = "SELECT * FROM user WHERE username = '$username';";
      $res = $conn -> query($sql);

          if ($res) {
              if ($res -> num_rows == 1){
                $row = $res -> fetch_row();
                if(password_verify($pwd, $row[2])){
                  session_start();
                  $_SESSION['id'] = $row[0];
                  header('Location: index.php');
                  exit();
                  }
              } else {
                  $_SESSION['error'] = 'Helytelen felhasználónév vagy jelszó!';
                  echo "<div id='honapkepei'><p>Helytelen felhasználónév vagy jelszó!</p></div>";
                  echo "<div id='noreg'><a href='login.php' class='nav-link'>Próbálja újra!</a></div>";
              }
          }
          else {
              header('Location: index.php');
              exit();
          }
      }

    }
    echo "</body>";
echo "</html>";
