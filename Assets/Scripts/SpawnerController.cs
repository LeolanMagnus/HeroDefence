using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrystalScripts
{

    public class SpawnerController : MonoBehaviour
    {

        public float basisMeasure;
        public float counter;
        public int vaveCounter;
        public bool vaveCleared;

        // Use this for initialization
        void Start()
        {
            vaveCounter = 0;
            vaveCleared = false;
            counter = 10;
        }

        // Update is called once per frame
        void Update()
        {
            Tic();
            CreateVave();
        }

        private int CheckLvl()
        {
            //TODO: Get all tagged player Get object lvl variable & summ it
            throw new NotImplementedException();
        }

        void CreateVave()
        {
            if (true && counter < 0) {
                var vave = new VaveEntity {
                    Level = vaveCounter,
                    HeroesSummLevel = CheckLvl()
                };
                counter = 10;
                Spawn(vave);
                vaveCounter++;
            }
        }

        void Spawn(VaveEntity vave)
        {
            //TODO: Spawner
            Vector3 vectorSpavner = new Vector3(basisMeasure, basisMeasure);
        }

        void Tic()
        {
            //todo time-related counter
            counter -= counter * Time.deltaTime;
        }
    }
}
