<?php
  function kategoriak(){
      include '../config/connect.php';
      $sql = mysqli_query($conn, "SELECT * FROM kategoriak;");

      while ($row = mysqli_fetch_assoc($sql)){
        echo "<table class='category-table'>";
  			echo "<tr><td class='main-category' colspan='2'>".$row['kat_cim']."</td></tr>";
  			alkategoriak($row['kat_id']);
  			echo "</table>";
      }
  }

  function alkategoriak($kapcs_id){
    include '../config/connect.php';
    $sql = mysqli_query("SELECT kat_id, alkat_id, alkat_cim, alkat_leiras FROM kategoriak, alkategoriak WHERE ($kapcs_id = kategoriak.kat_id) AND ($kapcs_id = alkategoriak.kapcs_id)");

  }
