<?php
session_start();
require_once("../config/connect.php");
    if (isset($_POST["reg"])){

    $email = trim($_POST["email"]);
    $user = trim($_POST["username"]);
    $pwd = trim($_POST["password"]);
    $pwd2 = trim($_POST["password2"]);
    $neme = trim($_POST["neme"]);
    $bemutatkozas = trim($_POST["bemutatkozas"]);

    if (($pwd == $pwd2) && ($user != $pwd) && (strlen($pwd) > 6)){
        $sql = "INSERT INTO user(username, password, neme, email, bemutatkozas, regdatum) VALUES ('$user','$pwd','$neme','$email','$bemutatkozas',CURDATE());";

        $conn -> query($sql);
        if ($conn -> error == 0){
            $_SESSION['reg'] = "Sikeres regisztráció!";
            echo "<p>Sikeres regisztráció!</p>";
            echo "<a href='../php/index.php'>Vissza a főoldalra</a>";
        }
        else {
            $_SESSION['reg'] = "A regisztráció sikertelen!";
        }
    }
}
else {
  die();
}
