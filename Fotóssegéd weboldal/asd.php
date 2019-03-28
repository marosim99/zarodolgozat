<?php

		$sql = "SELECT * FROM gepek";
			  $res = $conn -> query($sql);
			  $numRows = $res -> num_rows;

				if (isset($_GET['page'])){
					$page = $_GET['page'];
				} else {
					$page = 1;
				}

				$productNum = 10;
				$record = ($page-1) * 10;
				$sql .= " LIMIT $record, $productNum";
				$res = $conn -> query($sql);

				if(isset($_GET['keresesertek']) AND !empty($_GET['keresesertek'])){
					$keres = trim($_GET['keresesertek']);
				$sql = "SELECT * FROM gepek WHERE gyarto LIKE '%$keres%' OR sorozat LIKE '%$keres%';";


				}else
				{

						$sql = "SELECT * FROM gepek";
				}

				if(isset($_GET['keresesertek']) AND !empty($_GET['keresesertek']))
				{
				$search = mysqli_real_escape_string($conn,$_GET['keresesertek']);
				$sql_keres = "SELECT * FROM gepek WHERE gyarto LIKE '%$search%' OR sorozat LIKE '%$search%' OR tipus LIKE '%$search%';";

				}else
				{
						$sql_keres = "SELECT * FROM gepek";
				}
