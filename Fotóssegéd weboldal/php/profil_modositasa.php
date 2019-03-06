<?php
    require_once("../config/connect.php");
    session_start();
      $id = $_SESSION['id'];

     $sql="SELECT * FROM user WHERE id='$id';";
     $res = $conn -> query($sql);
     $row = $res -> fetch_assoc();

     $email = $row["email"];
     $user = $row["username"];
     $bemutatkozas = $row["bemutatkozas"];
 ?>
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
        require "menu.php";
     ?>
 <br>
 <form class="flex-container" method="post" action="update.php">
 <div class="card text-center bg-dark mx-auto" id=cardform><br>
   <div class="card-header" id="label">
     Profiladatok módosítása
   </div>
   <div class="card-body bg-secondary" id="label">
  <div class="d-flex justify-content-start">
     <div>
        <img src="../kepek/ppic.png" alt="" class="rounded float-left" id="profpic"/>
    </div>
    <div class="d-flex align-items-center flex-column" style="width: 900px;">
      <label id="label">Frofilkép feltöltése</label>
    <div class="d-flex flex-row">
     <div class="custom-file">

       <input type="file" class="custom-file-input" id="customFile" name="profkep">
       <label class="custom-file-label" for="customFile">Kép tallózása</label>
     </div>
    <button type="submit" class="btn btn-dark" id="submitbtn" name="update">Adatok frissítése</button>
    </div>
      <div class="form-group">
        <br>
        <label for="exampleFormControlTextarea1" id="label">Bemutatkozás módosítása (500 karakter)</label>
        <textarea type="text" class="form-control" id="exampleFormControlTextarea1" rows="5" maxlength="500" name=bemutatkozas style="width: 450px;"><?php echo $bemutatkozas; ?></textarea>
      </div>
</div>
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
</body>
