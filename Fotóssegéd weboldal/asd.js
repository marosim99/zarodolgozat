<script>
         $(document).ready(function(){

            $(document).on("change","#gyarto", function(){
            let gyarto = $(this).val();
            console.log(gyarto);

                if(gyarto != "alap"){
                  $.get("select_sorozat.php?gyarto="+gyarto,function(kiir){
                      $("#select").html(kiir);
                  });
                }
              });

              $(document).on("change","#sorozat",function(){
                let sorozat = $(this).val();
                $("#form_action").attr("action", "upload.php?sorozat="+sorozat);

              });

            });
</script>
