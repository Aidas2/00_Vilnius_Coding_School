package lt.bulevicius;

import java.awt.Graphics;
import java.awt.Graphics2D;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class Game extends JPanel {
	
    int x = 0;
    int y = 0;
    public void moveBall() {
    	
        x = x + 1;
        y = y + 10;
    }
    
    public void paint(Graphics g) {
        super.paint(g);
        Graphics2D g2d = (Graphics2D) g;
        g2d.fillOval(x, y, 50, 50);
    }

    public static void main(String[] args) throws InterruptedException {
    	
        JFrame frame = new JFrame("Sample Frame");
        Game game = new Game();
        frame.add(game);
        frame.setSize(800, 800);
        frame.setVisible(true);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        while (true) {
            game.moveBall();
            game.repaint();
            Thread.sleep(500);
        }
    }
}