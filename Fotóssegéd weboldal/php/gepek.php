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
        span{
           color: darkred;
        }
        </style>

    <title>Fotós segéd</title>
  </head>
  <body>
    <?php
      session_start();
      require_once '../config/connect.php';
      require "menu.php";

      $sql = "SELECT * FROM gepek";

      $res = $conn -> query($sql);
      $numRows = $res -> num_rows;



      $res = $conn -> query($sql);

      $tabla = "";
      if ($res){
        $tabla = "<table class='table table-hover table-dark text-center'>"
                . "<thead>"
                . "<tr>"
                . "<th scope='col'>Gyártó</th>"
                . "<th scope='col'>Sorozat</th>"
                . "<th scope='col'>Típus</th>"
                . "<th scope='col'>Pixel</th>"
                . "<th scope='col'>Szenzor</th>"
                . "<th scope='col'>Objektív foglalat</th>"
                . "<th scope='col'>Ár</th>"
                . "</tr>"
                . "</thead>"
                . "<tbody>";

      while ($row = $res -> fetch_array()){
          $tabla .= "<tr>"
                  . "<td>{$row[1]}</td>"
                  . "<td>{$row[2]}</td>"
                  . "<td>{$row[3]}</td>"
                  . "<td>{$row[4]}</td>"
                  . "<td>{$row[5]}</td>"
                  . "<td>{$row[6]}</td>"
                  . "<td>{$row[7]}Ft</td>"
                  . "</tr>";
    }
    $tabla  .="</tbody>"
            . "</table>";

}

    ?>
	<div id="honapkepei">
	<p>Legnépszerűbb fényképezőgépek</p>
	</div>

  <?php
    echo $tabla;
  ?>


    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
