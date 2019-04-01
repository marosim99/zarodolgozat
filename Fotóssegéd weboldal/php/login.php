<!doctype html>
<html lang="hu">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

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
<br>
<div class="card text-center bg-dark mx-auto" id=cardform>
  <div class="card-header" id="label">
		<div class="form-group" >
        <p>Bejelentkezés</p>
    </div>
  </div>
  <div class="card-body bg-secondary" id="label">
      <form class="flex-container" action="../php/belep.php" method="post">
    <div class="form-group">
			<label id="label">Felhasználónév</label>
			<input type="username" class="form-control" id="exampleFormControlInput1" name="username" required>
    </div>
		<div class="form-group">
			<label id="label">Jelszó</label>
			<input type="password" class="form-control" id="exampleFormControlInput1" name="password" required>
      <span id="pwdError"></span>
		</div>
		<div class="form-group">
		<button type="submit" class="btn btn-dark" id="loginbutton" name="belep">Belépés</button>
    </form>
		</div>
  </div>
  </div>


	<div id="noreg">
	<p><a class="nav-link" href="regisztracio.php">Nincs még felhasználói fiókja? Regisztráljon ide kattintva!</p>
	</div>



    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
