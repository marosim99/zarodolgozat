<?php
require_once '../config/connect.php';
$sql_gy = "SELECT gyarto, id FROM gepek GROUP BY gyarto";
$res_gy = $conn -> query($sql_gy);

$gyarto = '<select class="form-control" id="gyarto">
  <option value="alap">Válassz</option>';

  while($row = $res_gy -> fetch_assoc()){
      $gyarto.= "<label id='label'>Fényképezőgép típusa</label><option value='{$row['gyarto']}'> {$row['gyarto']} </option>";
  }
  $gyarto .= "</select>";
