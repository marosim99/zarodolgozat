<!doctype html>
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
      require_once '../config/connect.php';
      require "menu.php";

      $sql = "SELECT * FROM objektiv";

      $res = $conn -> query($sql);
      $numRows = $res -> num_rows;

      $numPages = ceil($numRows / 8);
      $oldalak = "";

      for ($i = 1; $i<= $numPages; $i++){
      $oldalak .= "<a href='objektivek.php?page={$i}'>{$i}</a>";
      }

      if (isset($_GET['page'])){
          $page = $_GET['page'];
      } else {
          $page = 1;
      }

      if ($page > 9) {  $page = 9; }
      if ($page < 1) {  $page = 1; }

      $productNum = 8;
      $record = ($page-1) * 8;
      $sql .= " LIMIT $record, $productNum";
      $res = $conn -> query($sql);

      $tabla = "";
      if ($res){
        $tabla = "<table class='table table-hover table-dark text-center'>"
                . "<thead>"
                . "<tr>"
                . "<th scope='col'>Típus</th>"
                . "<th scope='col'>Gyártó</th>"
                . "<th scope='col'>Név</th>"
                . "<th scope='col'>Gyújtótáv</th>"
                . "<th scope='col'>Stabilizátor</th>"
                . "<th scope='col'>Legszűkebb blende</th>"
                . "<th scope='col'>Legnagyobb blende</th>"
                . "<th scope='col'>Hossz</th>"
                . "<th scope='col'>Súly</th>"
                . "</tr>"
                . "</thead>"
                . "<tbody>";

      while ($row = $res -> fetch_array()){
          $tabla .= "<tr>"
                  . "<td>{$row[1]}</td>"
                  . "<td>{$row[2]}</td>"
                  . "<td>{$row[3]}</td>"
                  . "<td>{$row[4]}mm</td>";
                  if($row[5]==0){
                    $tabla .= "<td>Nincs</td>";
                  }else{
                    $tabla .= "<td>Van</td>";
                  }
                  $tabla .= "<td>f/{$row[6]}</td>"
                  . "<td>f/{$row[7]}</td>"
                  . "<td>{$row[8]}mm</td>"
                  . "<td>{$row[9]}g</td>"
                  . "</tr>";
    }
    $tabla  .="</tbody>"
            . "</table>";

}

    ?>
	<div id="honapkepei">
	<p>Legnépszerűbb objektívek</p>
	</div>

  <?php
    echo'<nav id="text-center">Oldalak: ';
      echo $oldalak;
    echo'</nav>';
    echo $tabla;
  ?>

  </body>
</html>
