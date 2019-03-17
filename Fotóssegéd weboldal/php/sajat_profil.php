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

    <title>Fotós segéd</title>
  </head>
  <body>
    <?php
      require_once("../config/connect.php");
      session_start();
      require "menu.php";

       $id = $_SESSION['id'];

       $sql="SELECT * FROM user WHERE id='$id';";
       $res = $conn -> query($sql);
       $row = $res -> fetch_assoc();

       $email = $row["email"];
       $user = $row["username"];
       $pwd = $row["password"];
       $bemutatkozas = $row["bemutatkozas"];

       $profImg = "";
       if(file_exists("../kepek/profkep/".$id.".jpg"))
       {
         $profImg = '../kepek/profkep/'.$id.'.jpg';
       } else if(file_exists("../kepek/profkep/".$id.".png"))
       {
         $profImg = '../kepek/profkep/'.$id.'.png';
       }
       else {
         $profImg = '../kepek/profkep/placeholder.jpg';
       }
    ?>
<br>
<div class="card text-center bg-dark mx-auto" id="cardform"><br>
  <div class="card-header" id="label">
    Profiladatok
  </div>
  <div class="card-body bg-secondary" id="label">

   <div class="d-flex justify-content-start">
          <div>
            <img src="<?php echo $profImg; ?>" alt="" class="rounded float-left" id="profpic"/>
          </div>
        <div class="d-flex align-items-start flex-column" style="width: 900px;">
           <br>
           <label for="exampleFormControlTextarea1" id="label_nagy">Bemutatkozás:</label>
           <p><?php echo $bemutatkozas; ?></p>
        </div>
  </div>
      <div class="d-flex align-items-start">
        <br>
        <p id="label_nagy">Felhasználónév: <?php echo $user; ?></p>
      </div>
      <div class="d-flex align-items-start">
      <br>
       <p id="label_nagy">Email-cím: <?php echo $email; ?></p>
     </div>
     <div class="d-flex align-items-start">
     <br>
      <p id="label_nagy">Feltöltött képek: <?php  ?></p>
    </div>

    <div id="noreg">
       <p><a class="nav-link" href="profil_modositasa.php">Profiladatok módosítása</a></p>
    </div>

   </div>
   </div>
 </form>
</body>
