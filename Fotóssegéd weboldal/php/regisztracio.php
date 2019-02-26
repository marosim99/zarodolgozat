<?php
session_start();
require_once("../config/connect.php");
    if (!isset($_POST["reg"])){
        die();
    }
    $email = trim($_POST["email"]);
    $user = trim($_POST["username"]);
    $pwd = trim($_POST["password"]);
    $pwd2 = trim($_POST["password2"]);
    $neme = trim($_POST["neme"]);
    $bemutatkozas = trim($_POST["bemutatkozas"]);

    if (($pwd == $pwdc) && ($user != $pwd) && (strlen($user) > 6 ) && (strlen($pwd) > 6)){
        $sql = "INSERT INTO user(username, password, neme, email, bemutatkozas, regdatum) VALUES ('$user','$pwd','$neme','$email','$bemutatkozas',CURDATE());";

        $conn -> query($sql);
        if ($conn -> $error == 0){
            $_SESSION['reg'] = "Sikeres regisztráció!";
        }
        else {
            $_SESSION['reg'] = "A regisztráció sikertelen!";
        }
    }
