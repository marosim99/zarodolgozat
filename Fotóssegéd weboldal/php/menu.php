<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
<a class="navbar-brand" href="index.php">Fotós segéd</a>
<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
  <span class="navbar-toggler-icon"></span>
</button>
<div class="collapse navbar-collapse" id="navbarNav">
  <ul class="navbar-nav">
    <li class="nav-item">
      <a class="nav-link" href="gepek.php"> Fényképezőgépek
        <span class="sr-only">(current)</span></a>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="objektivek.php"> Objektívek </a>
    </li>
    <?php
    if(isset($_SESSION['id'])){
      echo'<li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
        Fényképek
      </a>
      <div class="dropdown-menu" aria-labelledby="navbarDropdown">
        <a class="dropdown-item" href="galeria.php">Galéria</a>
        <div class="dropdown-divider"></div>
        <a class="dropdown-item" href="sajat_kepek.php">Saját képek</a>
        <a class="dropdown-item" href="kep_feltolt.php">Fénykép feltöltése</a>
      </div>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="chatroom.php"> Chat szoba </a>
    </li>';
  }
  ?>
  </ul>
  <ul class="navbar-nav ml-auto">
    <?php
    if(isset($_SESSION['id'])){
      echo '<li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
        Beállítások
      </a>
      <div class="dropdown-menu" aria-labelledby="navbarDropdown">
        <a class="dropdown-item" href="sajat_profil.php">Profil áttekintése</a>
        <a class="dropdown-item" href="profil_modositasa.php">Profil módosítása</a>
        <div class="dropdown-divider"></div>
        <a class="dropdown-item" href="#">Hibabejelentés</a>
      </div>
    </li>
      <li class="nav-item" id="reg">
      <a class="nav-link" href="logout.php"> Kilépés </a>
      </li>';
    }
    else {
      echo '<li class="nav-item" id="reg">
      <a class="nav-link" href="login.php"> Bejelentkezés/Regisztráció </a>
      </li>';
    }
     ?>
  </ul>
</div>
</nav>
