<?php
    require "header.php";
 ?>

	<div id="login-text">
	<p>Bejelentkezés</p>
	</div>


		<div class="form-group" id="col-75">
      <form class="flex-container" action="../php/belep.php" method="post">
			<label id="label">Felhasználónév</label>
			<input type="username" class="form-control" id="exampleFormControlInput1" name="username">
		</div>
		<div class="form-group" id="col-75">
			<label id="label">Jelszó</label>
			<input type="password" class="form-control" id="exampleFormControlInput1" name="password">
		</div>
		<div class="form-group" id="col-75">
		<button type="submit" class="btn btn-dark" id="submitbtn" name="belep">Belépés</button>
    </form>
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
