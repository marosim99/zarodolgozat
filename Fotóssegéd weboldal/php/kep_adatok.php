<!DOCTYPE html>
<html lang="hu">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/bootstrap.min.js"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>

    <link rel="stylesheet" href="../style/bootstrap.min.css">
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
              <p id="label_közepes">Készítő: </p><p id="label_közepes" class="message-name"><a href="user_profil.php?id=<?php echo $id; ?>"> <?php echo " ".$user; ?></a></p>
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

</body>
</html>
