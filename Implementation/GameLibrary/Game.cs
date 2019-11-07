﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary {
  public enum GameState {
    LOADING,
    TITLE_SCREEN,
    ON_MAP,
    FIGHTING,
    DEAD,
    INVENTORY,
  }

    public class Game {
        private static Game game;

        public Character Character { get; private set; }
        public GameState State { get; private set; }
        public Roll Roll { get; private set; }
        public Rush Rush {get; private set; }
    private Game() {
      State = GameState.LOADING;
    }

    public static Game GetGame() {
      if (game == null)
        game = new Game();
      return game;
    }

    public void ChangeState(GameState newState) {
      State = newState;
    }

    public void SetCharacter(Character character) {
      Character = character;
      character.weapon = new Weapon(1);
    }
  }
}
