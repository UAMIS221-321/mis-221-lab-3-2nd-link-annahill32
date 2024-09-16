// start main 


string enjoymentLevel = GetEnjoymentLevel();

string stadium = GetStadiumRecommendation(enjoymentLevel);

string game = GetGameRecommendation(stadium);

DisplayStadiumDetails (stadium, game);

// end main




// methods


static string GetEnjoymentLevel(){
    System.Console.WriteLine("Please enter your enjoyment level (Boring, Average, Fun, Epic)");
    string enjoymentLevel = Console.ReadLine().ToLower();
    return enjoymentLevel;
}

static string GetStadiumRecommendation (string enjoymentLevel){
    if (enjoymentLevel.ToLower() == "boring")
    {
        return "Neyland Stadium";
    }
    else if (enjoymentLevel.ToLower() == "average"){
        return "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel.ToLower() == "fun"){
        return "Tiger Stadium";
    }
    else if (enjoymentLevel.ToLower() == "epic"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else {
        return "invalid";

    }


}

static string GetGameRecommendation (string stadiumRecommendation){
    if (stadiumRecommendation == "Neyland Stadium"){
        return "vs Kent State";
    }
    else if (stadiumRecommendation == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    }
    else if (stadiumRecommendation == "Tiger Stadium"){
        return "vs Alabama";
    }
    else if (stadiumRecommendation == "Saban Field at Bryant-Denny Stadium"){
        return "vs Auburn";
    }
    else {
        return "invalid";
    }
}


static void DisplayStadiumDetails (string stadium, string game){
    if (stadium == "invalid" && game == "invalid"){
        System.Console.WriteLine("Input invalid");
    }
    System.Console.WriteLine($"Based upon your enjoyment level, a game at {stadium} {game} is recommended for you to attend.");
}

    

// extras
