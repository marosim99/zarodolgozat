<?php
    require "header.php";
    require_once("../config/connect.php");

      $id = $_SESSION['id'];

     $sql="SELECT * FROM user WHERE id='$id';";
     $res = $conn -> query($sql);
     $row = $res -> fetch_assoc();

     $email = $row["email"];
     $user = $row["username"];
     $bemutatkozas = $row["bemutatkozas"];
 ?>
 <br>
 <form class="flex-container" method="post" action="update.php">
 <div class="card text-center bg-dark mx-auto w-50">
   <div class="card-header" id="label">
     Profiladatok módosítása
   </div>

   <div class="card-body bg-secondary" id="label">
     <h5 class="card-title">Fofilkép feltöltése</h5>
     <div class="custom-file" id="input">
       <input type="file" class="custom-file-input" id="customFile">
       <label class="custom-file-label" for="customFile">Kép tallózása</label>
    </div>
       <div class="form-group">
         <br>
        <label id="label">Új email-cím</label>
   			<input value="<?php echo $email; ?>" name="email" type="email" class="form-control" id="exampleFormControlInput1" placeholder="valaki@valami.com" required>
         <span id="emailError"></span>
   		</div>
      <div class="form-group">
  			<label id="label">Új felhasználónév</label>
  			<input value="<?php echo $user; ?>" name="username" type="text" class="form-control" id="exampleFormControlInput1" required>
        <span id="userError"></span>
  		</div>
  		<div class="form-group">
  			<label id="label">Új jelszó</label>
  			<input name="password" type="password" class="form-control" id="exampleFormControlInput1" required>
        <span id="pwdError"></span>
  		</div>
  		<div class="form-group">
  			<label id="label">Új jelszó megerősítése</label>
  			<input name="password2" type="password" class="form-control" id="exampleFormControlInput1" required>
        <span id="pwd2Error"></span>
  		</div>
      <div class="form-group">
  			<label for="exampleFormControlTextarea1" id="label">Bemutatkozás módosítása (500 karakter)</label>
  			<textarea type="text" class="form-control" id="exampleFormControlTextarea1" rows="4" maxlength="500" name=bemutatkozas><?php echo $bemutatkozas; ?></textarea>
  		</div>

     <div class="form-group">
 		<button type="submit" class="btn btn-dark" id="submitbtn" name="update">Adatok frissítése</button>
 		</div>

    </div>
    </div>
  </form>
