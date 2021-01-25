$(document).ready(function() {
    $(".Reply-open-button-1").click(function () {
        $("div.Reply-div-1").show("slow");
    
        $("div.market-div-1").hide("slow");
        $("div.Alert-div-1").hide("slow");
        $("div.Close-div-1").hide("slow");
    });

    $(".Alert-open-button-1").click(function () {
        $("div.Alert-div-1").show("slow");
    
        $("div.market-div-1").hide("slow");
        $("div.Reply-div-1").hide("slow");
        $("div.Close-div-1").hide("slow");
    });

    $(".Close-open-button-1").click(function () {
        $("div.Close-div-1").show("slow");
    
        $("div.market-div-1").hide("slow");
        $("div.Alert-div-1").hide("slow");
        $("div.Reply-div-1").hide("slow");
    });

    $(".market-open-button-1").click(function () {
        $("div.market-div-1").show("slow");
    
        $("div.Close-div-1").hide("slow");
        $("div.Alert-div-1").hide("slow");
        $("div.Reply-div-1").hide("slow");
    });



    $(".Hide-1").click(function() {
        $(".div-1").hide("slow");
    });
});