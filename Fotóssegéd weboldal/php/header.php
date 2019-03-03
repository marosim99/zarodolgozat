<?php
  //session_start();
?>
<!doctype html>
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

        <style>
        
        </style>

    <title>Fotós segéd</title>
  </head>
  <body>
	<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <a class="navbar-brand" href="index.php">Fotós segéd</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item">
        <a class="nav-link" href="#"> Fényképezőgépek
          <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#"> Feltöltések </a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#"> Fórum </a>
      </li>
    </ul>
    <ul class="navbar-nav ml-auto">
      <?php
      if(isset($_SESSION['id'])){
        echo '<li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Beállítások
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
          <a class="dropdown-item" href="profil_modositasa.php">Profil módosítása</a>
          <a class="dropdown-item" href="#">funkció2</a>
          <div class="dropdown-divider"></div>
          <a class="dropdown-item" href="#">Hibabejelentés</a>
        </div>
      </li>
        <li class="nav-item" id="reg">
    		<a class="nav-link" href="logout.php"> Kilépés </a>
    	  </li>';
      }
      else {
        echo '<li class="nav-item" id="reg">
    		<a class="nav-link" href="login.php"> Bejelentkezés/Regisztráció </a>
    	  </li>';
      }
       ?>
    </ul>
  </div>
</nav>
<div>
  <?php
  /*if(isset($_SESSION['id'])){
    echo "Belépve";
  }
  else {
    echo "kilépve";
  }*/
   ?>
</div>
