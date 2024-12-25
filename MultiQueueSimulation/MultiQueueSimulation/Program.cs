﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueTesting;
using MultiQueueModels;

namespace MultiQueueSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SimulationSystem system = new SimulationSystem();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenuForm mainMenuForm = new MainMenuForm(system);

            Application.Run(mainMenuForm);

            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
        }
    }
}