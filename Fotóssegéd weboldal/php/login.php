<!doctype html>
<html lang="hu">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>
    <script src="../JS/bootstrap.min.js"></script>

    <link rel="stylesheet" href="../style/bootstrap.min.css">
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



  </body>
</html>
