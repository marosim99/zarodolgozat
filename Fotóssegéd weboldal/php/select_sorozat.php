<?php
require_once '../config/connect.php';
if(isset($_GET['gyarto'])){
$gyarto= $_GET['gyarto'];
$sql_sor = "SELECT id, sorozat FROM gepek WHERE gyarto='$gyarto';";
$res_sor = $conn -> query($sql_sor);

$sorozat = '<label id="label">Fényképezőgép sorozatszáma</label><select class="form-control" id="sorozat">
  <option value="alap">Válassz</option>';

  while($row = $res_sor -> fetch_assoc()){
      $sorozat.= "<option value='{$row['id']}'> {$row['sorozat']} </option>";
  }
  $sorozat .= "</select>";
  echo $sorozat;
}
