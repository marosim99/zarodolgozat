<!doctype html>
<html lang="hu">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
   <link rel="stylesheet" href="../style/styles.css">

    <title>Fotós segéd</title>
  </head>
  <body>
    <?php
      session_start();
       require "menu.php";
       require '../config/connect.php';

       $sql="SELECT user.username, kepek.fajlnev, kepek.cim FROM kepek INNER JOIN fotokeszites ON kepek.id = fotokeszites.kepid INNER JOIN user ON fotokeszites.userid = user.id  ORDER BY feltolt_datum DESC LIMIT 5;";
       $res = $conn -> query($sql);

    ?>
	<div id="honapkepei">
	<p>Utoljára feltölött képek</p>
	</div>

  <div id="carouselExampleFade" class="carousel slide carousel-fade" data-ride="carousel">
    <div class="carousel-inner">

<?php
$counter = 1;
while($row = $res -> fetch_assoc()){

    echo'<div class="carousel-item ';
    if($counter <= 1)
    {
      echo "active";
    }
      echo'">
      <img class="d-block w-100" src="../kepek/galeria/'.$row['fajlnev'].'" alt="'.$row["cim"].'">
    <div class="carousel-caption d-none d-md-block">
    <h4>'.$row["cim"].'</h4>
    <p>'.$row["username"].' fényképe</p>
    </div>
    </div>';
    $counter++;
  }
?>

</div>
<a class="carousel-control-prev" href="#carouselExampleFade" role="button" data-slide="prev">
	<span class="carousel-control-prev-icon" aria-hidden="true"></span>
	<span class="sr-only">Previous</span>
</a>
<a class="carousel-control-next" href="#carouselExampleFade" role="button" data-slide="next">
	<span class="carousel-control-next-icon" aria-hidden="true"></span>
	<span class="sr-only">Next</span>
</a>
</div><br>
<div id="felsorolas">
  <?php
  if(!isset($_SESSION['id'])){
    echo'<p>Regisztráljon az oldalra, hogy elérje az alábbi funkciókat:</p>
    <ul>
    <li>Képfeltöltés</li>
    <li>Mások képeinek megtekintése</li>
    <li>Chat</li>
    </ul>
    </div>';
}
?>
<div class="clearfix"></div>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
