import numpy as np
import skfuzzy as fuzz
from skfuzzy import control as ctrl
import matplotlib.pyplot as plt

# 1. New Antecedent/Consequent objects hold universe variables and membership functions
# Трафик от 0 до 10 (0 = няма коли, 10 = задръстване)
traffic = ctrl.Antecedent(np.arange(0, 11, 1), 'traffic')

# Време от 0 до 10 (0 = буря/лед, 10 = слънчево и сухо)
weather = ctrl.Antecedent(np.arange(0, 11, 1), 'weather')

# Видимост от 0 до 10 (0 = гъста мъгла, 10 = перфектна видимост)
visibility = ctrl.Antecedent(np.arange(0, 11, 1), 'visibility')

# Препоръчителна скорост от 0 до 130 км/ч (магистрала)
speed = ctrl.Consequent(np.arange(0, 131, 1), 'speed')

# 2. Auto-membership function population is possible with .automf(3, 5, or 7)
# Създава автоматично 'poor', 'average', 'good'
weather.automf(3)
visibility.automf(3)

# Custom membership functions can be built interactively with a familiar,
# Pythonic API. Нека сами да дефинираме трафика, за да са по-ясни термините:
traffic['light'] = fuzz.trimf(traffic.universe, [0, 0, 5])
traffic['moderate'] = fuzz.trimf(traffic.universe, [0, 5, 10])
traffic['heavy'] = fuzz.trimf(traffic.universe, [5, 10, 10])

# Дефинираме изхода (скорост) с 3 категории: бавно, умерено, бързо
speed['slow'] = fuzz.trimf(speed.universe, [0, 0, 65])
speed['medium'] = fuzz.trimf(speed.universe, [0, 65, 130])
speed['fast'] = fuzz.trimf(speed.universe, [65, 130, 130])

# (Опционално: Можете да видите графиките с метода .view())
# weather['average'].view()
# traffic.view()
# speed.view()

# 3. Fuzzy rules
# Правило 1: Ако времето е лошо (poor) ИЛИ видимостта е лоша (poor) ИЛИ трафикът е тежък (heavy), тогава скоростта трябва да е бавна
rule1 = ctrl.Rule(weather['poor'] | visibility['poor'] | traffic['heavy'], speed['slow'])

# Правило 2: Ако времето е средно (average) И видимостта е средна (average) ИЛИ трафикът е умерен (moderate), тогава скоростта е умерена
rule2 = ctrl.Rule(traffic['moderate'] | (weather['average'] & visibility['average']), speed['medium'])

# Правило 3: Ако времето е добро (good) И видимостта е добра (good) И трафикът е лек (light), тогава скоростта е бърза
rule3 = ctrl.Rule(weather['good'] & visibility['good'] & traffic['light'], speed['fast'])

# 4. Control System Creation and Simulation
speed_ctrl = ctrl.ControlSystem([rule1, rule2, rule3])

# Създаваме симулацията, на която ще подаваме конкретни входни данни
driving_sim = ctrl.ControlSystemSimulation(speed_ctrl)

# Подаваме входни данни за конкретната ситуация
# Пример: нормален трафик (4/10), перфектно време (10/10), отлична видимост (10/10)
driving_sim.input['traffic'] = 4.0
driving_sim.input['weather'] = 10.0
driving_sim.input['visibility'] = 10.0

# 5. Crunch the numbers
driving_sim.compute()

# Печатаме резултата
recommended_speed = driving_sim.output['speed']
print(f"При трафик=4.0, време=10.0, видимост=10.0 -> Препоръчителната скорост е: {recommended_speed:.2f} км/ч")

# Визуализация на изхода (отворете графиката, за да я видите)
speed.view(sim=driving_sim)
plt.show()
