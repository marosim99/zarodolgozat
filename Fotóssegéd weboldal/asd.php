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



	echo '<div class="row mb-3">';
	while($row = $res -> fetch_assoc()){
		echo '<div class="col-md-4">    
		<div class="card photo">
		<a class="lightbox" href="kep_adatok.php?kepid='.$row["id"].'
				&gepid='.$row["gepid"].'&userid='.$row["userid"].'">  
		
		<img src="../kepek/galeria/'.$row["fajlnev"].'" 
				alt="'.$row["cim"].'" class="card-img-top">
		</a>
		</div>
		</div>';
	}
	echo '</div>';
			
			
			
			
			
			
			
			
