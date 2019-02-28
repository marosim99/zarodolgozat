<?php
  require "header.php";
 ?>
	<div id="login-text">
	<p>Regisztráció</p>
	</div>


	<form class="flex-container" method="post" action="reg.php">
		<div class="form-group" id="col-75">
			<label id="label">Email-cím*</label>
			<input name="email" type="email" class="form-control" id="exampleFormControlInput1" placeholder="valaki@valami.com" required>
      <span id="emailError"></span>
		</div>
		<div class="form-group" id="col-75">
			<label id="label">Felhasználónév*</label>
			<input name="username" type="text" class="form-control" id="exampleFormControlInput1" required>
      <span id="userError"></span>
		</div>
		<div class="form-group" id="col-75">
			<label id="label">Jelszó*</label>
			<input name="password" type="password" class="form-control" id="exampleFormControlInput1" required>
      <span id="pwdError"></span>
		</div>
		<div class="form-group" id="col-75">
			<label id="label">Jelszó Megerősítés*</label>
			<input name="password2" type="password" class="form-control" id="exampleFormControlInput1" required>
      <span id="pwd2Error"></span>
		</div>


		<fieldset class="form-group" id="col-75">
			<div class="row" >
			<legend class="col-form-label col-sm-2 pt-0" id="label">Neme</legend>
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
  </fieldset>

		<div class="form-group" id="col-75">
			<label for="exampleFormControlTextarea1" id="label">Rövid bemutatkozás (max 500 karakter!)</label>
			<textarea type="text" class="form-control" id="exampleFormControlTextarea1" rows="4" maxlength="500" name=bemutatkozas></textarea>
		</div>


			<div id="small-text">
				<p>A csillaggal (*) jelölt mezők kitöltése kötelező</p>
			</div>
		<div class="form-group" id="col-75">
		<button type="submit" class="btn btn-dark" id="submitbtn" name="reg">Regisztráció</button>
		</div>
	</form>



    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
