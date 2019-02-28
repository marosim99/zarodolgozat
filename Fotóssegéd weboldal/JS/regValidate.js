$(document).ready(function(){
    $("button[name='reg']").click(function(event){

        console.log("Rám kattintottál");
        event.preventDefault();
    });
    $("input").focus(function(){
        $(this).addClass("aktiv");
    });
    $("input").blur(function(){
        $(this).removeClass("aktiv");
    });

    $("input[name='email']").blur(function(){
  		$("#emailError").html("");
  		let minta = /(?=.*[a-z])(?=.*[@])(?=.*[\.])/;
  		let joEmail = false;
  		let email = $(this).val();
  		joEmail = minta.test(email);

  		if(!joEmail){
  			$("#emailError").html("Hibás email formátum");
  		}
  	});

    $("input[name='username']").blur(function(){
  		$("#userError").html("");
          if($(this).val().length < 6){
              $("#userError").text("Legalább 6 karakter hosszúnak kell lennie!");
          }
      });

	$("input[name='password']").blur(function(){
		$("#pwdError").html("");
		let minta = /(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[_%?!$@&\.]).{6,}/;
		let joJelszo = false;
		let jelszo = $(this).val();
		joJelszo = minta.test(jelszo);
		if(!joJelszo){
			$("#pwdError").text("Legalább 6 karakter és szám, és speciális karakter!");
		}
	});
	$("input[name='password2']").keyup(function(){
		$("#pwd2Error").html("");
		let pwd = $("input[name='password']").val();
		let pwd2 = $(this).val();

		if(pwd !== pwd2){
			$("#pwd2Error").text("A két jelszó nem egyezik!");
		}
	});


});
