﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CongestionChargeGit.Persistence.Models;


namespace CongestionChargeGit
{
    public abstract class CalculateBase
    {
        public abstract void CalculateFee(Transport item);
        public static  TimeCalc CalculateTime(Transport item)
        { 
            TimeSpan amHours = TimeSpan.Zero;
            TimeSpan pmHours = TimeSpan.Zero;

            for (DateTime date = item.StartTime.Date; date <= item.EndTime.Date; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                TimeSpan startFeeTime = TimeRange.Start7Am;
                TimeSpan endFeeTime = TimeRange.Start7Pm;

                if (item.StartTime.Date == date && item.StartTime.TimeOfDay > TimeRange.Start7Am)
                {
                    startFeeTime = item.StartTime.TimeOfDay;
                }

                if (item.EndTime.Date == date && item.EndTime.TimeOfDay < TimeRange.Start7Pm)
                {
                    endFeeTime = item.EndTime.TimeOfDay;
                }

                if (endFeeTime > startFeeTime)
                {
                    if (startFeeTime < TimeRange.Start12Pm && endFeeTime < TimeRange.Start12Pm)
                    {
                        amHours += endFeeTime - startFeeTime;
                    }
                    else if (startFeeTime < TimeRange.Start12Pm && endFeeTime > TimeRange.Start12Pm)
                    {
                        amHours += TimeRange.Start12Pm - startFeeTime;
                        pmHours += endFeeTime - TimeRange.Start12Pm;
                    }
                    else if (startFeeTime > TimeRange.Start12Pm && endFeeTime > TimeRange.Start12Pm)
                    {
                        pmHours += endFeeTime - startFeeTime;
                    }
                }
            }
            return new TimeCalc
            {
                AmHours = amHours,
                PmHours = pmHours
            };

        }   

        }
    }
