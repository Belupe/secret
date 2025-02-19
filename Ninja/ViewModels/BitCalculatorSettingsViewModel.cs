﻿using System;
using System.Collections.Generic;
using System.Linq;
using Ninja.Models.Network;
using Ninja.Settings;

namespace Ninja.ViewModels
{
    using Models.Network;
    using Settings;

    public class BitCalculatorSettingsViewModel : ViewModelBase
    {
        #region Variables

        private readonly bool _isLoading;

        public List<BitCaluclatorNotation> Notations { get; private set; }

        private BitCaluclatorNotation _notation;

        public BitCaluclatorNotation Notation
        {
            get => _notation;
            set
            {
                if (value == _notation)
                    return;


                if (!_isLoading)
                    SettingsManager.Current.BitCalculator_Notation = value;


                _notation = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Constructor, load settings

        public BitCalculatorSettingsViewModel()
        {
            _isLoading = true;

            LoadSettings();

            _isLoading = false;
        }

        private void LoadSettings()
        {
            Notations = Enum.GetValues(typeof(BitCaluclatorNotation)).Cast<BitCaluclatorNotation>()
                .OrderBy(x => x.ToString()).ToList();
            Notation = Notations.First(x => x == SettingsManager.Current.BitCalculator_Notation);
        }

        #endregion
    }
}