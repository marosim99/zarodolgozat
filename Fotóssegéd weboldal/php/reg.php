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
    if (isset($_POST["reg"])){

    $email = trim($_POST["email"]);
    $user = trim($_POST["username"]);
    $pwd = trim($_POST["password"]);
    $pwd2 = trim($_POST["password2"]);
    $neme = trim($_POST["neme"]);
    $bemutatkozas = trim($_POST["bemutatkozas"]);

    //$error_user = false;
    $check_user = "SELECT username FROM user WHERE username ='$user';";
    $result_user = mysqli_query($conn,$check_user);
    //$count_user = mysqli_num_rows($result_user);

    //$error_email = false;
    $check_email = "SELECT email FROM user WHERE email ='$email';";
    $result_email = mysqli_query($conn,$check_email);
    //$count_email = mysqli_num_rows($result_email);

    if(mysqli_num_rows($result_user) > 0)
    {
      $_SESSION['reg'] = "A felhasználónév már foglalt!";
      echo "<div id='honapkepei'><p>A felhasználónév már foglalt!</p></div>";
      $error_user = true;
    }
    else{
      $error_user = false;
    }

    if(mysqli_num_rows($result_email) > 0){
      $_SESSION['reg'] = "Ez az email cím már foglalt!";
      echo "<div id='honapkepei'><p>Ez az email cím már foglalt!</p></div>";
      $error_email = true;
    }
    else{
      $error_email = false;
    }

    var_dump($error_user);
    var_dump($error_email);

        if ((!$error_user) && (!$error_email) && ($pwd == $pwd2) && ($user != $pwd) && (strlen($pwd) > 5)){
            $sql = "INSERT INTO user(username, password, neme, email, bemutatkozas, regdatum) VALUES ('$user','$pwd','$neme','$email','$bemutatkozas',CURDATE());";
            echo $sql;
            $conn -> query($sql);
            if ($conn -> error == 0){
                $_SESSION['reg'] = "Sikeres regisztráció!";
                echo "<div id='honapkepei'><p>Sikeres regisztráció!</p></div>";
                echo "<div id='noreg'><a href='login.php' class='nav-link'>Jelentkezzen be!</a></div>";
            }
            else {
                $_SESSION['reg'] = "A regisztráció sikertelen!";
                echo "<div id='honapkepei'><p>Sikertelen regisztráció!</p></div>";
                echo "<div id='noreg'><a href='regisztracio.php' class='nav-link'>Regisztráljon újra!</a></div>";
            }
        }
        else {
          $_SESSION['reg'] = "A regisztráció sikertelen!";
          echo "<div id='honapkepei'><p>Sikertelen regisztráció!</p></div>";
          echo "<div id='noreg'><a href='regisztracio.php' class='nav-link'>Regisztráljon újra!</a></div>";
        }

}
else {
  die();
}
echo "</body>";
