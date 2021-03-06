<!doctype html>
<html lang="hu">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <script src="../JS/jquery-3.3.1.min.js" charset="UTF-8"></script>
    <script src="../JS/bootstrap.min.js"></script>
    <script src="../JS/regValidate.js" charset="UTF-8"></script>

    <link rel="stylesheet" href="../style/bootstrap.min.css">
   <link rel="stylesheet" href="../style/styles.css">

    <title>Fotós segéd</title>
  </head>
  <body>
    <?php
       require "menu.php";
    ?>
 <br>

  <div class="card text-center bg-dark mx-auto" id=cardform>
    <div class="card-header" id="label">
      <div>
    	<p>Regisztráció</p>
    	</div>
    </div>
  <div class="card-body bg-secondary" id="label">
	<form class="flex-container" method="post" action="reg.php">
		<div class="form-group">
			<label id="label">Email-cím*</label>
			<input name="email" type="email" class="form-control" id="exampleFormControlInput1" placeholder="valaki@valami.com" required>
      <span id="emailError"></span>
		</div>
		<div class="form-group">
			<label id="label">Felhasználónév*</label>
			<input name="username" type="text" class="form-control" id="exampleFormControlInput1" required>
      <span id="userError"></span>
		</div>
		<div class="form-group">
			<label id="label">Jelszó*</label>
			<input name="password" type="password" class="form-control" id="exampleFormControlInput1" required>
      <span id="pwdError"></span>
		</div>
		<div class="form-group">
			<label id="label">Jelszó Megerősítés*</label>
			<input name="password2" type="password" class="form-control" id="exampleFormControlInput1" required>
      <span id="pwd2Error"></span>
		</div>

		<fieldset class="form-group">
			<div class="row">
			<legend class="col-form-label " id="label">Neme</legend>
		<div class="col-sm-10">
        <div class="form-check">
          <input class="form-check-input" type="radio" name="neme" id="gridRadios1" value="férfi" checked>
          <label class="form-check-label" for="gridRadios1" id="label">
            Férfi
          </label>
        </div>
        <div class="form-check">
          <input class="form-check-input" type="radio" name="neme" id="gridRadios2" value="nő">
          <label class="form-check-label" for="gridRadios2" id="label">
			         Nő
          </label>
        </div>
    </div>
    </div>
  </fieldset>

		<div class="form-group">
			<label for="exampleFormControlTextarea1" id="label">Rövid bemutatkozás (max 500 karakter!)</label>
			<textarea type="text" class="form-control" id="exampleFormControlTextarea1" rows="4" maxlength="500" name=bemutatkozas></textarea>
		</div>


			<div id="small-text">
				<p>A csillaggal (*) jelölt mezők kitöltése kötelező</p>
			</div>
		<div class="form-group">
		<button type="submit" class="btn btn-dark" id="submitbtn" name="reg">Regisztráció</button>
		</div>
	</form>

</div>

  </body>
</html>
