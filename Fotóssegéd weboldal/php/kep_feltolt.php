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

    <title>Fotós segéd</title>
  </head>
    <body>
      <?php
        session_start();
        require "menu.php";
        ?>

        <p id="honapkepei">Fénykép feltöltése</p>
        <form class="flex-container" method="post" action="upload.php">
        <div class="card text-center bg-dark mx-auto" id="cardform"><br>
          <div class="card-header" id="label">
            Adja meg a fénykép adatait
          </div>
       <div class="card-body bg-secondary" id="label">

           <div class="d-flex align-items-center flex-column" >
            <div class="custom-file">
              <input type="file" class="custom-file-input" id="profkep" name="profkep">
              <label class="custom-file-label" for="customFile">Kép tallózása</label>
            </div>
          </div>

          <div class="form-group">
              <br>
                <label id="label">Kép címe</label>
          			<input name="cim" class="form-control" id="exampleFormControlInput1" placeholder="pl.Balatoni naplemente" required>
          		</div>
          <div class="form-group">
              <br>
                <label for="exampleFormControlTextarea1" id="label">Rövid leírás a képről (opcionális)</label>
                <textarea type="text" class="form-control" id="exampleFormControlTextarea1" rows="5" maxlength="500" name=leiras></textarea>
          </div>
         		<div class="form-group">
         			<label id="label">Hol készült a kép?</label>
         			<input name="hely" class="form-control" id="exampleFormControlInput1" placeholder="pl.Balatonföldvár" required>
         		</div>
         		<div class="form-group">
         			<label id="label">Fénykép készítésének dátuma</label>
         			<input name="datum" type="date" class="form-control" id="exampleFormControlInput1" required>
         		</div>



            <div class="form-group">
        		<button type="submit" class="btn btn-dark" id="submitbtn" name="upload">Fénykép feltöltése</button>
        		</div>

           </div>
           </div>
         </form>
    </body>
</html>
