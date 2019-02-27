<?php
require_once("../config/connect.php");
    if (isset($_POST["reg"])){

    $email = trim($_POST["email"]);
    $user = trim($_POST["username"]);
    $pwd = trim($_POST["password"]);
    $pwd2 = trim($_POST["password2"]);
    $neme = trim($_POST["neme"]);
    $bemutatkozas = trim($_POST["bemutatkozas"]);

    require "header.php";

    if (($pwd == $pwd2) && ($user != $pwd) && (strlen($pwd) > 5)){
        $sql = "INSERT INTO user(username, password, neme, email, bemutatkozas, regdatum) VALUES ('$user','$pwd','$neme','$email','$bemutatkozas',CURDATE());";
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
