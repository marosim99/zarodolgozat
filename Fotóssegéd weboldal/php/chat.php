    <?php
       require "menu.php";
       session_start();
       require_once("../config/connect.php");

    if (isset($_POST["kuldes"])){

      $id = $_SESSION["id"];
      $uzenet = trim($_POST["uzenet"]);

      if(empty($uzenet)){
        header('Location: chatroom.php');
        die();
      }
      else{

    $sql = "INSERT INTO chat(uzenet, datum, user_id) VALUES ('$uzenet',CURRENT_TIMESTAMP,$id)";
    $conn -> query($sql);
    header('Location: chatroom.php');



    }
  }
    else {
      die();
    }
echo "</body>";
