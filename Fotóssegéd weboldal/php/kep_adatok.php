<!DOCTYPE html>
<html lang="hu">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>

    <link href="../style/fontawesome-free-5.8.1-web/css/all.css" rel="stylesheet">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
   <link rel="stylesheet" href="../style/styles.css">

    <title>Fotós segéd</title>
  </head>
  <body>

    <?php
      session_start();
      require '../config/connect.php';
      require 'menu.php';

      $id = $_GET["userid"];
      $kepid = $_GET["kepid"];
      $gepid = $_GET["gepid"];

      $sql_kep = "SELECT fajlnev, cim, leiras, hely, keszites_datum FROM kepek WHERE id = $kepid;";
      $res_kep = $conn -> query($sql_kep);
      $row = $res_kep -> fetch_assoc();

      $fajlnev = $row["fajlnev"];
      $cim = $row["cim"];
      $leiras = $row["leiras"];
      $hely = $row["hely"];
      $datum = $row["keszites_datum"];

      $sql_user = "SELECT username FROM user WHERE id=$id;";
      $res_user = $conn -> query($sql_user);
      $row = $res_user -> fetch_assoc();

      $user = $row["username"];

      $sql_gep = "SELECT gyarto, sorozat FROM gepek WHERE id=$gepid;";
      $res_gep = $conn -> query($sql_gep);
      $row = $res_gep -> fetch_assoc();

      $gep = $row["gyarto"]." ".$row["sorozat"];

      ?>
      <br>
      <div class="card text-center bg-dark mx-auto" id="cardform"><br>
        <div class="card-header" id="label">
          Képadatok
        </div>

      <div class="card-body bg-secondary" id="label">
                   <img src="../kepek/galeria/<?php echo $fajlnev; ?>" alt="" class="card-img-top"/>
           <div>
              <br>
              <p id="label_nagy"><?php echo $cim; ?></p>
           </div>
            <div>
               <br>
               <label for="d-flex justify-content-center" id="label_közepes">Rövid leírás a képről:</label>
               <p id="label_közepes"><?php echo $leiras; ?></p>
            </div>
            <div id="label_közepes_border"></div>
            <div class="d-flex align-items-start">
              <br>
              <p id="label_közepes">Készítő: </p><a href="user_profil.php?id=<?php echo $id; ?>"><p id="label_közepes"> <?php echo " ".$user; ?></p></a>
            </div>
            <div class="d-flex align-items-start">
              <br>
              <p id="label_közepes">Fényképezőgép: <?php echo $gep; ?></p>
            </div>
            <div class="d-flex align-items-start">
            <br>
             <p id="label_közepes">Hely: <?php echo $hely; ?></p>
           </div>
           <div class="d-flex align-items-start">
           <br>
            <p id="label_közepes">Készítés dátuma: <?php echo $datum; ?></p>
          </div>
      </div>
    </div>

<script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
