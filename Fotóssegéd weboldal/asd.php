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
