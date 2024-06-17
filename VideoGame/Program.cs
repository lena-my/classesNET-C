public class Character {
    private string name;
    private int lifePoints;
    private int forceAtack;
    private int forceDefense;

//constructor
    public Character (string name, int lifePoints, int forceAtack, int forceDefense){
        this.name = name;
        this.lifePoints = lifePoints;
        this.forceAtack = forceAtack;
        this.forceDefense = forceDefense;
    }

// calculate if the character is alive
    public bool IsAlive(){
        bool alive = lifePoints > 0 ? true : false;
        return alive;
    }
    
// method to calculate the life points of the attacked character
    public int Attack (Character attacked, Character attacker){
        attacked.lifePoints = attacked.lifePoints - (attacker.forceAtack - attacked.forceDefense);
        return lifePoints;
    }
}