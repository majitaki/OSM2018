using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Utility
{
    static class OpinionUpdater
    {
        public static double UpdateBelief(double prior_belief, double can_weight, InfoEnum opinion)
        {
            double cupd = DecideCupd(opinion, can_weight);
            var numerator = cupd * prior_belief;
            var denominator = (1 - cupd) * (1 - prior_belief) + cupd * prior_belief;

            return numerator / denominator;
        }

        public static double UpdateBelief(double init_belief, double can_weight, InfoEnum opinion, int count)
        {
            var prior_belief = init_belief;
            for (int i = 0; i < count; i++)
            {
                prior_belief = UpdateBelief(prior_belief, can_weight, opinion);
            }
            return prior_belief;
        }

        public static double DecideCupd(InfoEnum opinion, double can_weight)
        {
            if (opinion == InfoEnum.Green)
            {
                return can_weight;
            }
            else if (opinion == InfoEnum.Red)
            {
                return 1 - can_weight;
            }
            else
            {
                throw new Exception();
            }
        }

        public static double GetWeightForScale(double init_belief, double w_sigma, double b_sigma, int scale_index)
        {
            InfoEnum opinion;

            if (scale_index >= 0)
            {
                opinion = InfoEnum.Green;
            }
            else
            {
                opinion = InfoEnum.Red;
            }

            var diff = 0.00001;
            var init_can_weight = 0.500 + diff;
            double can_weight = 0;
            for (can_weight = init_can_weight; can_weight < 1; can_weight += diff)
            {
                var belief = UpdateBelief(init_belief, can_weight, opinion, Math.Abs(scale_index));
                if (belief <= b_sigma || belief >= w_sigma)
                {
                    break;
                }
            }

            if (can_weight >= 1)
            {
                throw new Exception();
            }

            return can_weight;
        }

        public static int GetU(double init_belief, double g_sigma, double r_sigma, double weight)
        {
            var current_belief = init_belief;
            int g_count = 0;
            int r_count = 0;

            while (current_belief < g_sigma)
            {
                current_belief = OpinionUpdater.UpdateBelief(current_belief, weight, InfoEnum.Green);
                g_count++;
            }

            while (current_belief > r_sigma)
            {
                current_belief = OpinionUpdater.UpdateBelief(current_belief, weight, InfoEnum.Red);
                r_count++;
            }

            return (g_count <= r_count) ? g_count : r_count;
        }
    }
}
