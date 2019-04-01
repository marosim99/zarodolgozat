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

      $sql = "SELECT * FROM gepek";
      $res = $conn -> query($sql);
      $numRows = $res -> num_rows;

      $numPages = ceil($numRows / 10);
      $oldalak = "";

        for ($i = 1; $i<= $numPages; $i++){
        $oldalak .= "<a href='gepek.php?page={$i}'>{$i}</a>";
        }

        if (isset($_GET['page'])){
            $page = $_GET['page'];
        } else {
            $page = 1;
        }

        if ($page > 9) {  $page = 9; }
        if ($page < 1) {  $page = 1; }

        $productNum = 10;
        $record = ($page-1) * 10;
        $sql .= " LIMIT $record, $productNum";
        $res = $conn -> query($sql);

        $tabla = "";

        if ($res){
        $tabla = "<table class='table table-hover table-dark text-center' id='dtBasicExample'>"
                . "<thead>"
                . "<tr>"
                . "<th scope='col' class='th-sm'>Gyártó</th>"
                . "<th scope='col' class='th-sm'>Sorozat</th>"
                . "<th scope='col' class='th-sm'>Típus</th>"
                . "<th scope='col' class='th-sm'>Pixel</th>"
                . "<th scope='col' class='th-sm'>Szenzor</th>"
                . "<th scope='col' class='th-sm'>Objektív foglalat</th>"
                . "<th scope='col' class='th-sm'>Ár</th>"
                . "</tr>"
                . "</thead>"
                . "<tbody>";

      while ($row = $res -> fetch_array()){
          $tabla .= "<tr>"
                  . "<td>{$row[1]}</td>"
                  . "<td>{$row[2]}</td>"
                  . "<td>{$row[3]}</td>"
                  . "<td>{$row[4]} MPx</td>"
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
    echo'<nav id="text-center">Oldalak: ';
      echo $oldalak;
    echo'</nav>';
    echo $tabla;
  ?>

    
  </body>
</html>
