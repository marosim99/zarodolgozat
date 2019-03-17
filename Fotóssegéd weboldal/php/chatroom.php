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
      require_once("../config/connect.php");
      session_start();
      require "menu.php";
      echo '<br>
      <h2 class="text-center">Chat</h2><br>';

      echo '<div class="container-fluid w-50 scroll" id="scroll">';
      //echo '<div class="scroll" id="scroll">';

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
          $profImg = '../kepek/profkep/placeholder.jpg';
        }

        $sql_user = "SELECT username FROM user INNER JOIN chat ON user.id=chat.user_id WHERE id=$id LIMIT 1;";
        $res_user = $conn -> query($sql_user);
        if ($row_user = $res_user -> fetch_assoc()){
          $username = $row_user["username"];
        }


        echo '<div class="chat-container">
        <div class="chat-box center-block">
          <div class="row">
            <div class="col-xs-8 col-md-6">
              <img src="';
              echo $profImg;
              echo'"" class="message-photo">
              <h4 class="message-name">';
              echo $username;
              echo '</h4>
            </div>
            <div class="col-xs-4 col-md-6 text-right message-date">';
            echo $row[2];
            echo '</div>
          </div>
          <div class="row message-text">';
          echo $row[1];
          echo '</div>
          </div>
          </div>';
      }
      echo "</div>";
      //echo "</div>";

    ?>
<form method="post" action="chat.php">
<div class="container-fluid w-50">
  <div class="messaging center-block">
    <div class="row">
      <div class="col-md-12">
        <div class="input-group">
          <input type="text" class="form-control" name="uzenet">
          <span class="input-group-btn">
            <button type="submit" class="btn btn-default" name="kuldes">Küldés</button>
          </span>
        </div>
      </div>
    </div>
  </div>
</div>
</form>
<script>
  //$("#scroll").scrollTop($("#scroll")[0].scrollHeight);
  //$("#scroll").animate({scrollTop:$("#scroll")[0].scrollHeight}, 1000);
</script>

</body>
</html>
