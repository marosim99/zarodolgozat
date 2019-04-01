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
      require_once("../config/connect.php");
      session_start();
      require "menu.php";
      echo '<p id="honapkepei">Chat szoba</p><br>';

      echo '<div class="container scroll" id="scroll">';

      $sql="SELECT * FROM chat ORDER BY datum DESC LIMIT 25;";
      $res = $conn -> query($sql);

      while($row = $res -> fetch_row()){
        $id = $row[3];

        $profImg = "";
        if(file_exists("../kepek/profkep/".$id.".jpg"))
        {
          $profImg = '../kepek/profkep/'.$id.'.jpg';
        } else if(file_exists("../kepek/profkep/".$id.".png"))
        {
          $profImg = '../kepek/profkep/'.$id.'.png';
        }
        else {
          $profImg = '../kepek/profkep/placeholder.png';
        }

        $sql_user = "SELECT username FROM user INNER JOIN chat ON user.id=chat.user_id WHERE id=$id LIMIT 1;";
        $res_user = $conn -> query($sql_user);
        if ($row_user = $res_user -> fetch_assoc()){
          $username = $row_user["username"];
        }


        echo '
        <div class="chat-box">
          <div class="row">
            <div class="col-xs-8 col-md-6">
              <img src="';
              echo $profImg;
              echo'"" class="message-photo">
              <h4 class="message-name"><a href="user_profil.php?id='.$id.'">';
              echo $username;
              echo '</a></h4>
            </div>
            <div class="col-xs-4 col-md-6 text-right message-date">';
            echo $row[2];
            echo '</div>
          </div>
          <div class="row message-text">';
          echo $row[1];
          echo '</div>

          </div>';
      }
      echo "</div>";

    ?>
<form method="post" action="chat.php">
<div class="center">
  <div class="messaging">
    <div class="row">
      <div class="col-md-12">
        <div class="input-group">
          <input type="text" class="form-control" name="uzenet" placeholder="Írja ide elküldeni kívánt üzenetét" maxlength="350">
          <span class="input-group-btn">
            <button type="submit" class="btn btn-dark" name="kuldes">Küldés</button><br>
          </span>
        </div>
      </div>
    </div>
  </div>
</div>
</form>

</html>
